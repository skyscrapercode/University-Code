<?php
// Include database connection
include 'db_connection.php';

// Check if the request is POST and required data is present
if ($_SERVER['REQUEST_METHOD'] === 'POST' && isset($_POST['id'], $_POST['status'])) {
    $id = intval($_POST['id']);
    $status = $_POST['status'];

    // Validate the status value
    if (in_array($status, ['Accepted', 'Rejected'])) {
        // Update the status in the database
        $stmt = $conn->prepare("UPDATE leave_requests SET status = ? WHERE id = ?");
        $stmt->bind_param("si", $status, $id);

        if ($stmt->execute()) {
            echo json_encode(["success" => true, "message" => "Status updated successfully."]);
        } else {
            echo json_encode(["success" => false, "message" => "Failed to update status."]);
        }

        $stmt->close();
    } else {
        echo json_encode(["success" => false, "message" => "Invalid status value."]);
    }
} else {
    echo json_encode(["success" => false, "message" => "Invalid request."]);
}

// Close the database connection
$conn->close();
?>
